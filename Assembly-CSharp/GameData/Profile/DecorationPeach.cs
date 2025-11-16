using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x0200030E RID: 782
	public class DecorationPeach : DecorationBase
	{
		// Token: 0x06005D22 RID: 23842 RVA: 0x001D4484 File Offset: 0x001D2684
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationPeach()
		{
			Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationPeach");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr);
			DecorationPeach.NativeFieldInfoPtr_bestEvalRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr, "bestEvalRate");
			DecorationPeach.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr, 100682493);
			DecorationPeach.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr, 100682494);
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x001D44F0 File Offset: 0x001D26F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232860, XrefRangeEnd = 232861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationPeach.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x001D4540 File Offset: 0x001D2740
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationPeach() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationPeach>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationPeach.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x00032D33 File Offset: 0x00030F33
		public DecorationPeach(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x001D457C File Offset: 0x001D277C
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x00032D3C File Offset: 0x00030F3C
		public unsafe float bestEvalRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPeach.NativeFieldInfoPtr_bestEvalRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPeach.NativeFieldInfoPtr_bestEvalRate)) = value;
			}
		}

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeFieldInfoPtr_bestEvalRate;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
