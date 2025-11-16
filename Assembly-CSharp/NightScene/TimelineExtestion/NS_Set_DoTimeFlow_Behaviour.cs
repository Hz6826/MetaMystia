using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DD RID: 477
	public class NS_Set_DoTimeFlow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C29 RID: 15401 RVA: 0x0016B314 File Offset: 0x00169514
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoTimeFlow_Behaviour()
		{
			Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoTimeFlow_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr);
			NS_Set_DoTimeFlow_Behaviour.NativeFieldInfoPtr_shouldFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr, "shouldFlow");
			NS_Set_DoTimeFlow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr, 100674471);
			NS_Set_DoTimeFlow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr, 100674472);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0016B380 File Offset: 0x00169580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136691, XrefRangeEnd = 136696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoTimeFlow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0016B3BC File Offset: 0x001695BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoTimeFlow_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoTimeFlow_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoTimeFlow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00021C67 File Offset: 0x0001FE67
		public NS_Set_DoTimeFlow_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x0016B3F8 File Offset: 0x001695F8
		// (set) Token: 0x06003C2E RID: 15406 RVA: 0x00021C70 File Offset: 0x0001FE70
		public unsafe bool shouldFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoTimeFlow_Behaviour.NativeFieldInfoPtr_shouldFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoTimeFlow_Behaviour.NativeFieldInfoPtr_shouldFlow)) = value;
			}
		}

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeFieldInfoPtr_shouldFlow;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
