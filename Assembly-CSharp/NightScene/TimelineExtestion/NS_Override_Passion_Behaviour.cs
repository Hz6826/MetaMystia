using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F7 RID: 503
	public class NS_Override_Passion_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CF1 RID: 15601 RVA: 0x0016D4B0 File Offset: 0x0016B6B0
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Passion_Behaviour()
		{
			Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Passion_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr);
			NS_Override_Passion_Behaviour.NativeFieldInfoPtr_newPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr, "newPassion");
			NS_Override_Passion_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr, 100674536);
			NS_Override_Passion_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr, 100674537);
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x0016D51C File Offset: 0x0016B71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137022, XrefRangeEnd = 137027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Passion_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x0016D558 File Offset: 0x0016B758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Passion_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Passion_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Passion_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0002223A File Offset: 0x0002043A
		public NS_Override_Passion_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x0016D594 File Offset: 0x0016B794
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x00022243 File Offset: 0x00020443
		public unsafe int newPassion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Passion_Behaviour.NativeFieldInfoPtr_newPassion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Passion_Behaviour.NativeFieldInfoPtr_newPassion)) = value;
			}
		}

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeFieldInfoPtr_newPassion;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
