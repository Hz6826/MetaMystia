using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008D RID: 141
	[Serializable]
	public class SpellEarth : PatchouliSpellBase
	{
		// Token: 0x06000DB2 RID: 3506 RVA: 0x000CBF8C File Offset: 0x000CA18C
		// Note: this type is marked as 'beforefieldinit'.
		static SpellEarth()
		{
			Il2CppClassPointerStore<SpellEarth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellEarth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr);
			SpellEarth.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, "amplitude");
			SpellEarth.NativeFieldInfoPtr_shakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, "shakeDuration");
			SpellEarth.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, "fadeTime");
			SpellEarth.NativeFieldInfoPtr_earthQuakeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, "earthQuakeSfx");
			SpellEarth.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, 100665574);
			SpellEarth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr, 100665575);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000CC034 File Offset: 0x000CA234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44239, XrefRangeEnd = 44241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string DescriptionMethodB(string oldText, int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellEarth.NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000CC098 File Offset: 0x000CA298
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellEarth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellEarth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellEarth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0000929B File Offset: 0x0000749B
		public SpellEarth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000CC0D4 File Offset: 0x000CA2D4
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000092A4 File Offset: 0x000074A4
		public unsafe float amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000CC0FC File Offset: 0x000CA2FC
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000092BF File Offset: 0x000074BF
		public unsafe float shakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_shakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_shakeDuration)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000CC124 File Offset: 0x000CA324
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000092DA File Offset: 0x000074DA
		public unsafe float fadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_fadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_fadeTime)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000CC14C File Offset: 0x000CA34C
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000092F5 File Offset: 0x000074F5
		public GlobalAudioManager.DelayAudioClip earthQuakeSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_earthQuakeSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellEarth.NativeFieldInfoPtr_earthQuakeSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_shakeDuration;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_earthQuakeSfx;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionMethodB_Public_Virtual_String_String_Int32_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
