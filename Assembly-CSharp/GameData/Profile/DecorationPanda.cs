using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x0200030D RID: 781
	public class DecorationPanda : DecorationBase
	{
		// Token: 0x06005D18 RID: 23832 RVA: 0x001D42EC File Offset: 0x001D24EC
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationPanda()
		{
			Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationPanda");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr);
			DecorationPanda.NativeFieldInfoPtr_moneyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr, "moneyMin");
			DecorationPanda.NativeFieldInfoPtr_moneyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr, "moneyMax");
			DecorationPanda.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr, "interval");
			DecorationPanda.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr, 100682491);
			DecorationPanda.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr, 100682492);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x001D4380 File Offset: 0x001D2580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232859, XrefRangeEnd = 232860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationPanda.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x001D43D0 File Offset: 0x001D25D0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationPanda() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationPanda>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationPanda.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x00032CD9 File Offset: 0x00030ED9
		public DecorationPanda(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x001D440C File Offset: 0x001D260C
		// (set) Token: 0x06005D1D RID: 23837 RVA: 0x00032CE2 File Offset: 0x00030EE2
		public unsafe int moneyMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_moneyMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_moneyMin)) = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x001D4434 File Offset: 0x001D2634
		// (set) Token: 0x06005D1F RID: 23839 RVA: 0x00032CFD File Offset: 0x00030EFD
		public unsafe int moneyMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_moneyMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_moneyMax)) = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x001D445C File Offset: 0x001D265C
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x00032D18 File Offset: 0x00030F18
		public unsafe int interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationPanda.NativeFieldInfoPtr_interval)) = value;
			}
		}

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeFieldInfoPtr_moneyMin;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeFieldInfoPtr_moneyMax;

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeFieldInfoPtr_interval;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
