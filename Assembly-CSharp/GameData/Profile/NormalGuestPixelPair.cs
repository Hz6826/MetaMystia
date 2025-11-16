using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile
{
	// Token: 0x020002E2 RID: 738
	[Serializable]
	public sealed class NormalGuestPixelPair : ValueType
	{
		// Token: 0x060059DF RID: 23007 RVA: 0x001CBDE4 File Offset: 0x001C9FE4
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuestPixelPair()
		{
			Il2CppClassPointerStore<NormalGuestPixelPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NormalGuestPixelPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestPixelPair>.NativeClassPtr);
			NormalGuestPixelPair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestPixelPair>.NativeClassPtr, "id");
			NormalGuestPixelPair.NativeFieldInfoPtr_skinSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestPixelPair>.NativeClassPtr, "skinSelections");
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x000308A8 File Offset: 0x0002EAA8
		public NormalGuestPixelPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x000308B1 File Offset: 0x0002EAB1
		public NormalGuestPixelPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestPixelPair>.NativeClassPtr))
		{
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x001CBE3C File Offset: 0x001CA03C
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x000308C3 File Offset: 0x0002EAC3
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelPair.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelPair.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060059E4 RID: 23012 RVA: 0x001CBE64 File Offset: 0x001CA064
		// (set) Token: 0x060059E5 RID: 23013 RVA: 0x000308DE File Offset: 0x0002EADE
		public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact> skinSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelPair.NativeFieldInfoPtr_skinSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelPair.NativeFieldInfoPtr_skinSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeFieldInfoPtr_skinSelections;
	}
}
