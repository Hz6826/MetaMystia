using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Common.CharacterUtility
{
	// Token: 0x02000457 RID: 1111
	public class HeightBlendedInputProcessorComponent : CharacterControllerUnitInputProcessorComponent
	{
		// Token: 0x06007AA2 RID: 31394 RVA: 0x0023552C File Offset: 0x0023372C
		// Note: this type is marked as 'beforefieldinit'.
		static HeightBlendedInputProcessorComponent()
		{
			Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "HeightBlendedInputProcessorComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr);
			HeightBlendedInputProcessorComponent.NativeFieldInfoPtr_heightMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, "heightMap");
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687881);
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687882);
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_OnInputPassed_Public_Virtual_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687883);
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_SampleColorAtCurrentCoordinate_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687884);
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687885);
			HeightBlendedInputProcessorComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, 100687886);
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x002355E8 File Offset: 0x002337E8
		public unsafe Vector3Int GridPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294865, XrefRangeEnd = 294880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00235624 File Offset: 0x00233824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294881, RefRangeEnd = 294884, XrefRangeStart = 294880, XrefRangeEnd = 294881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Tilemap heightMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(heightMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00235668 File Offset: 0x00233868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294884, XrefRangeEnd = 294893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 OnInputPassed(Vector2 input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_OnInputPassed_Public_Virtual_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x002356BC File Offset: 0x002338BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294957, RefRangeEnd = 294958, XrefRangeStart = 294893, XrefRangeEnd = 294957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SampleColorAtCurrentCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_SampleColorAtCurrentCoordinate_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x002356F8 File Offset: 0x002338F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270701, RefRangeEnd = 270703, XrefRangeStart = 270701, XrefRangeEnd = 270703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeightBlendedInputProcessorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x00235734 File Offset: 0x00233934
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeightBlendedInputProcessorComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x000422DE File Offset: 0x000404DE
		public HeightBlendedInputProcessorComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x00235770 File Offset: 0x00233970
		// (set) Token: 0x06007AAB RID: 31403 RVA: 0x000422E7 File Offset: 0x000404E7
		public unsafe Tilemap heightMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightBlendedInputProcessorComponent.NativeFieldInfoPtr_heightMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightBlendedInputProcessorComponent.NativeFieldInfoPtr_heightMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050AF RID: 20655
		private static readonly IntPtr NativeFieldInfoPtr_heightMap;

		// Token: 0x040050B0 RID: 20656
		private static readonly IntPtr NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0;

		// Token: 0x040050B1 RID: 20657
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_0;

		// Token: 0x040050B2 RID: 20658
		private static readonly IntPtr NativeMethodInfoPtr_OnInputPassed_Public_Virtual_Vector2_Vector2_0;

		// Token: 0x040050B3 RID: 20659
		private static readonly IntPtr NativeMethodInfoPtr_SampleColorAtCurrentCoordinate_Private_Single_0;

		// Token: 0x040050B4 RID: 20660
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040050B5 RID: 20661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F93 RID: 3987
		[ObfuscatedName("Common.CharacterUtility.HeightBlendedInputProcessorComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06011407 RID: 70663 RVA: 0x003F9454 File Offset: 0x003F7654
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr);
				HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr, "<>9");
				HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr, "<>9__5_0");
				HeightBlendedInputProcessorComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr, 100687888);
				HeightBlendedInputProcessorComponent.__c.NativeMethodInfoPtr__SampleColorAtCurrentCoordinate_b__5_0_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr, 100687889);
			}

			// Token: 0x06011408 RID: 70664 RVA: 0x003F94D0 File Offset: 0x003F76D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeightBlendedInputProcessorComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011409 RID: 70665 RVA: 0x003F950C File Offset: 0x003F770C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294864, XrefRangeEnd = 294865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _SampleColorAtCurrentCoordinate_b__5_0(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightBlendedInputProcessorComponent.__c.NativeMethodInfoPtr__SampleColorAtCurrentCoordinate_b__5_0_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601140A RID: 70666 RVA: 0x00095FE8 File Offset: 0x000941E8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170059AD RID: 22957
			// (get) Token: 0x0601140B RID: 70667 RVA: 0x003F9564 File Offset: 0x003F7764
			// (set) Token: 0x0601140C RID: 70668 RVA: 0x00095FF1 File Offset: 0x000941F1
			public unsafe static HeightBlendedInputProcessorComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeightBlendedInputProcessorComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059AE RID: 22958
			// (get) Token: 0x0601140D RID: 70669 RVA: 0x003F958C File Offset: 0x003F778C
			// (set) Token: 0x0601140E RID: 70670 RVA: 0x00096003 File Offset: 0x00094203
			public unsafe static Func<float, float, float> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HeightBlendedInputProcessorComponent.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE7A RID: 44666
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE7B RID: 44667
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400AE7C RID: 44668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE7D RID: 44669
			private static readonly IntPtr NativeMethodInfoPtr__SampleColorAtCurrentCoordinate_b__5_0_Internal_Single_Single_Single_0;
		}
	}
}
