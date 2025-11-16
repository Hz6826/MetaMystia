using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F8 RID: 504
	public class NS_Set_CanOpenTrash_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CF7 RID: 15607 RVA: 0x0016D5BC File Offset: 0x0016B7BC
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_CanOpenTrash_Behaviour()
		{
			Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_CanOpenTrash_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr);
			NS_Set_CanOpenTrash_Behaviour.NativeFieldInfoPtr_canOpenTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr, "canOpenTrash");
			NS_Set_CanOpenTrash_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr, 100674538);
			NS_Set_CanOpenTrash_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr, 100674539);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0016D628 File Offset: 0x0016B828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137027, XrefRangeEnd = 137030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_CanOpenTrash_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0016D664 File Offset: 0x0016B864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_CanOpenTrash_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_CanOpenTrash_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_CanOpenTrash_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0002225E File Offset: 0x0002045E
		public NS_Set_CanOpenTrash_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x0016D6A0 File Offset: 0x0016B8A0
		// (set) Token: 0x06003CFC RID: 15612 RVA: 0x00022267 File Offset: 0x00020467
		public unsafe bool canOpenTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_CanOpenTrash_Behaviour.NativeFieldInfoPtr_canOpenTrash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_CanOpenTrash_Behaviour.NativeFieldInfoPtr_canOpenTrash)) = value;
			}
		}

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeFieldInfoPtr_canOpenTrash;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
